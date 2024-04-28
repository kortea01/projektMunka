import { useRef } from "react";
import React from 'react';
import PropTypes from "prop-types";
import { useNavigate } from 'react-router-dom';
import { FaUser, FaLock } from "react-icons/fa";



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

    return (
        <div className="loginWrapper">s
        <div className="loginContainer">
            <form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
                <h1>Belépés</h1>
                <div className="input-box">
                    <label htmlFor="loginEmail">E-mail:</label>
                    <input type="email" id="loginEmail" placeholder="E-mail" ref={emailRef} />
                    <FaUser className="icon"/>
                </div>
                <div className="input-box">
                    <label htmlFor="loginPassword">Jelszó:</label>
                    <input type="password" id="loginPassword" placeholder="Jelszó" ref={passwordRef}/>
                    <FaLock className="icon" />
                </div>
                <div className="remember-forgot">
                    <label><input type="checkbox" />Emlékezz rám</label>
                    <a href="#">Elfelejtettem a jelszavam</a>
                </div>
            
                    <button type="submit">Belépés</button>
                    <button type="button" onClick={() => navigate('/register')}>Regisztráció</button>
            </form>
        </div>
    </div>
 
    );
}

LoginPage.propTypes = {
    onSubmit: PropTypes.func.isRequired
}

export default LoginPage;


/*import { useRef } from "react";
import React from 'react';
import PropTypes from "prop-types";
import { useNavigate } from 'react-router-dom';
import { FaUser, FaLock } from "react-icons/fa";


function LoginPage({ onSubmit }) {
    // Your code for the login form goes here

    const emailRef = useRef();
    const passwordRef = useRef();
    const navigate = useNavigate();

    const handleFormSubmit = async (e) => {
        e.preventDefault();
        const user = {
            email: emailRef.current.value,
            password: passwordRef.current.value,
            //role: "customer"       
        };
        const success = await onSubmit(user);

        if (success) {
          navigate('/user-profile');
        }
    };

    return (
    <div className="loginWrapper">
    <form style={{marginTop: "10px", marginBottom: "10px"}} onSubmit={handleFormSubmit}>
        <h1>Belépés</h1>
        <div className="input-box">
            <label htmlFor="loginEmail">E-mail:</label>
            <input type="email" id="loginEmail" placeholder="E-mail" ref={emailRef} />
            <FaUser className="icon"/>
        </div>
        <div className="input-box">
            <label htmlFor="loginPassword">Jelszó:</label>
            <input type="password" id="loginPassword" placeholder="Jelszó" ref={passwordRef}/>
            <FaLock className="icon" />
        </div>
        <div className="remember-forgot">
            <label><input type="checkbox" />Emlékezz rám</label>
            <a href="#">Elfelejtettem a jelszavam</a>
        </div>

            <button type="submit">Belépés</button>
            <button type="button" onClick={() => navigate('/register')}>Regisztráció</button>
    </form>
    </div>
    );
}

LoginPage.propTypes = {
    onSubmit: PropTypes.func.isRequired
}

export default LoginPage;*/