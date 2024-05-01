import React, { useEffect, useState } from 'react';

function MenuPage() {
    const [dishes, setDishes] = useState([]);

    useEffect(() => {
        menuQuery("all").then(data => setDishes(data));
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
            return data.data;
        } else {
            alert(data.message);
        }

    }

    return (
        <div className='menuWrapper'>
            <div className='menuContainer'>
                <div className='menuFilter'>
                    <button onClick={() => menuQuery("all").then(data => setDishes(data))}>Összes</button>
                    <button onClick={() => menuQuery("soup").then(data => setDishes(data))}>Levesek</button>
                    <button onClick={() => menuQuery("salad").then(data => setDishes(data))}>Saláták</button>
                    <button onClick={() => menuQuery("pizza").then(data => setDishes(data))}>Pizzák</button>
                    <button onClick={() => menuQuery("pasta").then(data => setDishes(data))}>Tészták</button>     
                    {/*<button onClick={() => menuQuery("risotto").then(data => setDishes(data))}>Rizottók</button>*/}
                    <button onClick={() => menuQuery("dessert").then(data => setDishes(data))}>Desszertek</button>
                    <button onClick={() => menuQuery("drinks").then(data => setDishes(data))}>Italok</button>
                    <button onClick={() => menuQuery("other").then(data => setDishes(data))}>Egyebek</button>

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
                <div className='menuPager'>1 2 utolso</div>
            </div>
        </div>
    );
}

export default MenuPage;