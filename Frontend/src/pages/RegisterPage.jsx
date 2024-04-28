import { useRef } from "react";

function RegisterPage() {
    // displayed for registaion
    const apiUrl = "http://localhost:8000/api" 
    const emailRef = useRef(null);
    const passwordRef = useRef(null);
    const lastNameRef = useRef(null);
    const firstNameRef = useRef(null);
    const phoneRef = useRef(null);
    const zipRef = useRef(null);
    const cityRef = useRef(null);
    const addressRef = useRef(null); 

    const handleFormSubmit = event => {
        event.preventDefault()
        const newUser = {
            email: emailRef.current.value,
            password: passwordRef.current.value,
            last_name: lastNameRef.current.value,
            first_name: firstNameRef.current.value,
            phone: phoneRef.current.value,
            zip: zipRef.current.value,
            city: cityRef.current.value,
            address: addressRef.current.value,
            role: "customer"
        
        };
        register(newUser);


    }

    const register = async userData => {
        const url = apiUrl + "/register";
        const response = await fetch(url, {
            method: "POST",
            body: JSON.stringify(userData),
            headers: {
                "Accept": "application/json",
                "Content-Type": "application/json"
            }

        });
        const data = await response.json();
        console.log(data);
        if (response.ok) {
            alert("Sikeres regisztráció!");
        } else {
            alert(data.message);
        }
        
    }

    return ( 
        
    <div class="container">
        <div className="registerWrapper">
                        <h2>Regisztráció</h2>
                        <form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
                        <div>
                            <label htmlFor="last_name">Vezetéknév:</label>
                            <input type="text" id="last_name" placeholder="Teszt" ref={lastNameRef}/>
                        </div>
                        <div>
                            <label htmlFor="first_name">Keresztnév:</label>
                            <input type="text" id="first_name" placeholder="Elek" ref={firstNameRef}/>
                        </div>
                        <div>
                            <label htmlFor="phone">Telefonszám:</label>
                            <input type="text" id="phone" placeholder="+36305004020" ref={phoneRef}/>
                        </div>
                        <div>
                            <label htmlFor="zip">Irányítószám:</label>
                            <input type="text" id="zip" placeholder="1094" ref={zipRef}/>
                        </div>
                        <div>
                            <label htmlFor="city">Város:</label>
                            <input type="text" id="city" placeholder="Budapest" ref={cityRef}/>
                        </div>
                        <div>
                            <label htmlFor="address">Cím:</label>
                            <input type="text" id="address" placeholder="Mester utca 15" ref={addressRef}/>
                        </div>

                        <div>
                            <label htmlFor="email">E-mail:</label>
                            <input type="email" id="email" placeholder="tesztelek@tesztelek.hu" ref={emailRef}/>
                        </div>
                        <div>
                            <label htmlFor="password">Jelszó:</label>
                            <input type="password" id="password" placeholder="tesztElek88" ref={passwordRef} />
                        </div>
        
                            <button type="submit">Register</button>
                        </form>
                    </div>
                </div>
    );
}

export default RegisterPage;