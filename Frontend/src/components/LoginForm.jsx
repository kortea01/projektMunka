import { useRef } from "react";

function LoginForm() {
    // Your code for the login form goes here

    const apiUrl = "http://localhost:8000/api" 
    const emailRef = useRef(null);
    const passwordRef = useRef(null);

    const handleFormSubmit = event => {
        event.preventDefault()
        const user = {
            email: emailRef.current.value,
            password: passwordRef.current.value,
            role: "customer"
        
        };
        login(user);


    }

    const login = async userData => {
        const url = apiUrl + "/login";
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
            alart("Sikeres belépés!");
        } else {
            alart(data.message);
        }
        
    }

    return (<form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
        <div>
            <label htmlFor="email">E-mail:</label>
            <input type="email" id="login_email" placeholder="Email" ref={emailRef} />
        </div>
        <div>
            <label htmlFor="password">Jelszó:</label>
            <input type="password" id="login_password" placeholder="Jelszó" ref={passwordRef}/>
        </div>

            <button type="submit">Login</button>
    </form>);
}

export default LoginForm;