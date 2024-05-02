import React from 'react';
import { Link } from 'react-router-dom';



function Navbar() {
    return (
	<nav className="main_nav">
        <ul className="d-flex flex-row align-items-center justify-content-start">
            <li><Link to="/">Főoldal</Link></li>
            <li><Link to="/about-us">Rólunk</Link></li>
            <li><Link to="/menu">Menü</Link></li>
            <li><Link to="/contact">Kapcsolat</Link></li>
            <li><Link to="/login">Bejelentkezés</Link></li>
            <li><Link to="/user-profile">Profil</Link></li>

        </ul>
    </nav>
    );
}

export default Navbar;