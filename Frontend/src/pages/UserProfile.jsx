import PropTypes from 'prop-types';
import React from 'react';
import { useRef } from 'react';
import { useEffect } from 'react';




function UserProfile(props) {

    useEffect(() => {
        if (props.user) {
            // code to run when props.user changes
        }
    }, [props.user]);

    if (!props.user) {
        return null; // or return a loading spinner, or some other placeholder
      }
    const { user, logoutClick } = props;
    const apiUrl = "http://localhost:8000/api" 
    const emailRef = useRef(null);
    const passwordRef = useRef(null);
    const lastNameRef = useRef(null);
    const firstNameRef = useRef(null);
    const phoneRef = useRef(null);
    const zipRef = useRef(null);
    const cityRef = useRef(null);
    const addressRef = useRef(null); 

    const handleFormSubmit = async (event) => {
        event.preventDefault();
    
        const updatedUser = {
            id: user.id, // Add the user's id
            last_name: lastNameRef.current.value,
            first_name: firstNameRef.current.value,
            phone: phoneRef.current.value,
            zip: zipRef.current.value,
            city: cityRef.current.value,
            address: addressRef.current.value,
            email: emailRef.current.value,
            password: passwordRef.current.value,
        };
    
        const response = async userData => {
            const url = apiUrl + "/user/" + userData.id; // Use the user's id in the URL
            const response = await fetch(url, {
                method: "PUT", // Use the PUT method
                body: JSON.stringify(userData),
                headers: {
                    "Accept": "application/json",
                    "Content-Type": "application/json"
                }
            });
    
        if (response.ok) {
            const data = await response.json();
                alert("Sikeres mentés!");
            } else {
                alert("A kérés sikertelen volt.");
            }
    
        };

        response(updatedUser);
    };
    

    return (
    <div className='container'>
        <div className='sidebar'>
            <nav>
                <div className='sidebar_header'>
                    <img className='avatar' src='./images/man.png' alt='avatar' />
                    <div className='username'><h4>{props.user.last_name} {props.user.first_name}</h4> </div>
                <ul className='sidebar_menu'>
                    <li><a href='/user-profile'>Profil</a></li>
                    <li><a href="#rendelesek">Rendelések</a></li>
                </ul>
                <div className='center'>
                    <button type="button" onClick={() => logoutClick()}>Kijelentkezés</button>
                </div>
                </div>
            </nav>
        </div>
        <div className='data'>
            <div className='profil'>
                <form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
                    <div>
                        <label htmlFor="last_name">Vezetéknév:</label>
                        <input type="text" id="last_name" ref={lastNameRef} defaultValue={props.user ? props.user.last_name : ''}/>
                    </div>
                    <div>
                        <label htmlFor="first_name">Keresztnév:</label>
                        <input type="text" id="first_name" ref={firstNameRef} defaultValue={props.user ? props.user.first_name : ''}/>
                    </div>
                    <div>
                        <label htmlFor="phone">Telefonszám:</label>
                        <input type="text" id="phone" ref={phoneRef} defaultValue={props.user ? props.user.phone : ''}/>
                    </div>
                    <div>
                        <label htmlFor="zip">Irányítószám:</label>
                        <input type="text" id="zip" ref={zipRef} defaultValue={props.user ? props.user.zip : ''}/>
                    </div>
                    <div>
                        <label htmlFor="city">Város:</label>
                        <input type="text" id="city" ref={cityRef} defaultValue={props.user ? props.user.city : ''}/>
                    </div>
                    <div>
                        <label htmlFor="address">Cím:</label>
                        <input type="text" id="address" ref={addressRef} defaultValue={props.user ? props.user.address : ''}/>
                    </div>
                    <div>
                        <label htmlFor="email">Email:</label>
                        <input type="text" id="email" ref={emailRef} defaultValue={props.user ? props.user.email : ''}/>
                    </div>
                    <div>
                        <label htmlFor="password">Jelszó:</label>
                        <input type="password" id="password" ref={passwordRef} />
                    </div>
                    <div>
                        <button type="submit">Mentés</button>
                    </div>
                </form>
            </div>

        </div>


    </div>

    );
}

UserProfile.propTypes = {
    user: PropTypes.object.isRequired,
    logoutClick: PropTypes.func.isRequired,
    //logoutEverywhereClick: PropTypes.func.isRequired
};

export default UserProfile;