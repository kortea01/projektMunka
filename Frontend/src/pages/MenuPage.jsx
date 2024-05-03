import React, { useEffect, useState } from 'react';
import { AiOutlineConsoleSql } from 'react-icons/ai';

function MenuPage() {
    const [dishes, setDishes] = useState([]);
    const [links, setLinks] = useState([]);

    useEffect(() => {
        menuQuery("all").then(data => {setDishes(data[0]);setLinks(data[1]);});
    }, []);

    async function menuQuery($category) {
        let url;
        if ($category != "all") {
            url = "http://localhost:8000/api/menu/category/" + $category;
        } else {
            url = "http://localhost:8000/api/menu/"
        }
        const response = await fetch(url, {
            method: "GET",
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json"
            }
        });

        const data = await response.json();
        if (response.ok) {
            console.log(data.data);
            console.log(data.links);
            setDishes(data.data);
            setLinks(data.links);
            return [data.data, data.links];
        } else {
            alert(data.message);
        }

    }

    return (
        <div className='menuWrapper'>
            <div className='menuContainer'>
                <div className='menuFilter'>
                    <button onClick={() => menuQuery("all").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Összes</button>
                    <button onClick={() => menuQuery("soup").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Levesek</button>
                    <button onClick={() => menuQuery("salad").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Saláták</button>
                    <button onClick={() => menuQuery("pizza").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Pizzák</button>
                    <button onClick={() => menuQuery("pasta").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Tészták</button>     
                    {/*<button onClick={() => menuQuery("risotto").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Rizottók</button>*/}
                    <button onClick={() => menuQuery("dessert").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Desszertek</button>
                    <button onClick={() => menuQuery("drinks").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Italok</button>
                    <button onClick={() => menuQuery("other").then(data => {setDishes(data[0]);setLinks(data[1]);})}>Egyebek</button>

                </div>
                <div className='menuItems'>
                    {dishes && dishes.map(dish => (
                        <div className='menuItem' key={dish.id}>
                            <div className='menuItemContent'>
                                <div className='dishImageContainer'><img className='dishImage' src={dish.img_url}></img></div>
                                <h3 className='dishName'>{dish.name}</h3>
                                <div className='dishDesc'>{dish.description}</div>
                                <div className='dishAllergen'>
                                    {dish.ingredients.map(ingredient => (
                                        <span key={ingredient}>{ingredient}</span>
                                    ))}
                                </div>
                                <div className='dishPrice'>{dish.price}</div>
                                <div className='dishButton'><button>kosárba</button></div>
                            </div>
                        </div>
                    ))}
                </div>
                <div className='menuPager'>
                    {links && links.map(link => (
                        link.url && (
                        <button key={link.url} className={(link.active && 'active')} onClick={() => menuQuery(link.url && link.url.split('/').pop()).then(data => {setDishes(data[0]);setLinks(data[1]);})}>
                           {link.label}
                        </button>
                        )
                    ))}
                </div>
            </div>
        </div>
    );
}

export default MenuPage;