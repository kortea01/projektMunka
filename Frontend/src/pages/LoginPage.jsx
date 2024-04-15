import { useRef } from "react";
import React from 'react';
import PropTypes from "prop-types";
import { useNavigate } from 'react-router-dom';


function LoginPage(props) {
    // Your code for the login form goes here

    const {onSubmit} = props;
    const navigate = useNavigate();
    const emailRef = useRef(null);
    const passwordRef = useRef(null);

    const handleFormSubmit = event => {
        event.preventDefault()
        const user = {
            email: emailRef.current.value,
            password: passwordRef.current.value,
            //role: "customer"       
        };
        onSubmit(user);
    
    }

    return (<form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
        <div>
            <label htmlFor="loginEmail">E-mail:</label>
            <input type="email" id="loginEmail" placeholder="E-mail" ref={emailRef} />
        </div>
        <div>
            <label htmlFor="loginPassword">Jelszó:</label>
            <input type="password" id="loginPassword" placeholder="Jelszó" ref={passwordRef}/>
        </div>

            <button type="submit">Belépés</button>
            <button type="button" onClick={() => navigate('/register')}>Regisztráció</button>
    </form>);
}

LoginPage.propTypes = {
    onSubmit: PropTypes.func.isRequired
}

export default LoginPage;