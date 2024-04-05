function LoginForm() {
    // Your code for the login form goes here

    return (<form style={{marginTop: "10px", marginBottom: "10px"}}>
        <div>
            <label htmlFor="email">E-mail:</label>
            <input type="email" id="email" placeholder="Email" />
        </div>
        <div>
            <label htmlFor="password">Jelszó:</label>
            <input type="password" id="password" placeholder="Jelszó" />
        </div>

            <button type="submit">Login</button>
    </form>);
}

export default LoginForm;