
import './App.css';
import UserProfile from './components/UserProfile';
import RegisterForm from './components/RegisterForm';
import LoginForm from './components/LoginForm';

function App() {
  
  // application main component
  const apiUrl = "http://localhost:8000/api" 
  const loggedIn = false; // dummy state


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
        alert("Sikeres belépés!");
    } else {
        alert(data.message);
    }
  }

  // redirect user based on state
  return (
    <main>
      {loggedIn ?
        <UserProfile />
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