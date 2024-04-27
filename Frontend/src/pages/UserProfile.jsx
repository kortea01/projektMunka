import PropTypes from 'prop-types';
import React from 'react';



function UserProfile(props) {
    const { user, logoutClick, logoutEverywhereClick } = props;


    return (
    <div className='container'>
        <div className='sidebar'>
            <nav className='sidebar'>
                <div className='sidebar_header'>
                    <img className='avatar' src='./images/dinosaur.png' alt='avatar' />
                    <h2>Szalontay Laci Panna Kitti</h2>
                
                <ul className='sidebar_menu'>
                    <li><a href='/user-profile'>Profil</a></li>
                    <li><a href="#rendelesek">Rendelések</a></li>
                </ul>
                <div className='center'><button type="button" onClick={() => logoutClick()}>Kijelentkezés</button></div>
                </div>
            </nav>
        </div>
        <div className='data'>
            <div className='profile'>
                <h2>Profil</h2>
                <p>Név: Szalontay Laci Panna Kitti</p>
                <p>E-mail:</p>
            </div>

        </div>


    </div>

    );
}

/*function UserProfile(props) {
    const { user, logoutClick, logoutEverywhereClick } = props;
    // displayed when user is logged in

    return (<div>
        <p>Bejelentkezve: {user.first_name}</p>
        <button type="button" onClick={() => logoutClick()}>Kijelentkezés</button>
        <button type="button" onClick={() => logoutEverywhereClick()}>Kijelentkezés mindenhonnan</button>
    </div>);
}*/

UserProfile.propTypes = {
    user: PropTypes.object.isRequired,
    logoutClick: PropTypes.func.isRequired,
    logoutEverywhereClick: PropTypes.func.isRequired
};

export default UserProfile;