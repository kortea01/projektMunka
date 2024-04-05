function RegisterForm() {
    // displayed for registaion

    return ( <form>
        <div>
            <label htmlFor="lastName">Vezetéknév:</label>
            <input type="text" id="lastName" placeholder="Vezetéknév" />
        </div>
        <div>
            <label htmlFor="firstName">Keresztnév:</label>
            <input type="text" id="firstName" placeholder="Keresztnév" />
        </div>
        <div>
            <label htmlFor="email">E-mail:</label>
            <input type="email" id="email" placeholder="Email" />
        </div>
        <div>
            <label htmlFor="password">Jelszó:</label>
            <input type="password" id="password" placeholder="Jelszó" />
        </div>
        
        <button type="submit">Register</button>
    </form>
        
    );
}

export default RegisterForm;