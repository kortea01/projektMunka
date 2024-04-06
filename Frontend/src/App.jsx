
import './App.css';
import UserProfile from './components/UserProfile';
import RegisterForm from './components/RegisterForm';
import LoginForm from './components/LoginForm';
import { useEffect, useState } from 'react';

function App() {
  
  // application main component
  const apiUrl = "http://localhost:8000/api"
  const [token, setToken] = useState('');
  const [userData, setUserData] = useState(null);

  const loadUserData = async () => {
    const url = apiUrl + "/user";
    const response = await fetch(url, {
        method: "GET",
        headers: {
            "Accept": "application/json",
            "Authorization": "Bearer " + token
        }
    });
    const data = await response.json();
    if (response.ok) {
      setUserData(data);
    } else {
      setToken('');
      
    }
  } 

  useEffect(() => {
    if (token) {
      loadUserData();
    } else {
      setUserData(null);
    }
  }, [token]);



  const login = async formData => {
    const url = apiUrl + "/login";
    const response = await fetch(url, {
        method: "POST",
        body: JSON.stringify(formData),
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        }

    });
    const data = await response.json();
    console.log(data);
    if (response.ok) {
        setToken(data.token);
        alert("Sikeres belépés!");
    } else {
        alert(data.message);
    }
  }

  // redirect user based on state
  return (
    <main>
      {userData !== null ?
        <UserProfile user={userData} />
        :
        <>    
          <RegisterForm />
          <LoginForm onSubmit={login} />
        </>
      }
    </main>
  );
}

export default App;