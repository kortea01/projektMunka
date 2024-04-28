
import './App.css';
import UserProfile from './pages/UserProfile';
import RegisterPage from './pages/RegisterPage';
import LoginPage from './pages/LoginPage';
import AboutUs from './pages/AboutUs';
import { useEffect, useState } from 'react';
import { createBrowserRouter } from 'react-router-dom';
import { RouterProvider } from 'react-router-dom';
import Layout from './components/Layout';
import HomePage from './pages/HomePage';


function App() {

  // application main component
  const apiUrl = "http://localhost:8000/api"
  const [token, setToken] = useState('');
  const [userData, setUserData] = useState(null);



  const loadUserData = async () => {
    const token = localStorage.getItem('token');
    const url = apiUrl + "/user";
    const response = await fetch(url, {
      method: "GET",
      headers: {
        Accept: "application/json",
        Authorization: "Bearer " + token
      }
    });
    const data = await response.json();
    if (response.ok) {
      setUserData(data);
    } else {
      localStorage.removeItem('token');
      setToken('');

    }
  }

  useEffect(() => {
    const storedToken = localStorage.getItem('token');
    if (storedToken) {
      setToken(storedToken);
    }
  }, []);

  useEffect(() => {
    if (token) {
      loadUserData();
    } else {
      setUserData(null);
    }
  }, [token]);

  window.addEventListener('scroll', function() {
    var dynamic = document.querySelector('.navbarpic');
    var newHeight = Math.max(100, 350 - window.scrollY);
    dynamic.style.height = newHeight + 'px';
  });

  const login = async formData => {
    const url = apiUrl + "/login";
    const response = await fetch(url, {
      method: "POST",
      body: JSON.stringify(formData),
      headers: {
        Accept: "application/json",
        "Content-Type": "application/json"
      }

    });
    const data = await response.json();
    console.log(data);
    if (response.ok) {
      const tokenData = data.token.split('|');
      const token = tokenData[1];
      setToken(token);
      // Add the following line to make the token available in other functions
      localStorage.setItem('token', token);
      loadUserData();
      //console.log(token); 
      //router.navigate('/user-profile');
      alert("Sikeres belépés!");
    } else {
      alert(data.message);
    }
  };

  const logout = async () => {
    const url = apiUrl + "/logout";
    const response = await fetch(url, {
      method: "POST",
      headers: {
        Accept: "application/json",
        Authorization: "Bearer " + token
      }
    })
    if (response.ok) {
      localStorage.removeItem('token');
      setToken('');
      router.navigate('/');
      alert("Sikeres kijelentkezés!");
    } else {
      const data = await response.json();
      alert(data.message);
    }
  }

  const logoutEverywhere = async () => {
    const url = apiUrl + "/logout-everywhere";
    const response = await fetch(url, {
      method: "POST",
      headers: {
        Accept: "application/json",
        Authorization: "Bearer " + token
      }
    })
    if (response.ok) {
      localStorage.removeItem('token');
      setToken('');
      router.navigate('/');
      alert("Sikeres kijelentkezés!");
    } else {
      const data = await response.json();
      alert(data.message);
    }
  }

  const router = createBrowserRouter([{
    path: "/",
    element: <Layout />,
    children: [
      {
        path: "/",
        element: <HomePage />,
      },
      {
        path: "/about-us",
        element: <AboutUs />,
      },
      {
        path: "/user-profile",
        element: <UserProfile  user={userData} logoutClick={logout} logoutEverywhereClick={logoutEverywhere} />,
      },
      {
        path: "/register",
        element: <RegisterPage user={userData} />,
      },
      {
        path: "/login",
        element: <LoginPage onSubmit={login} />,
      }
    ],
  },
  ]);
  // redirect user based on state
  return (

    //<div className='wrapper'>

      <RouterProvider router={router} />

    //</div>
  );
  //  // redirect user based on state
  //  return (
  //  
  //    <div>
  //      <RouterProvider router={router} />
  //      
  //    <main>
  //      /*{userData !== null ?
  //        <UserProfile user={userData} logoutClick={logout} logoutEverywhereClick={logoutEverywhere}/>
  //        :
  //        <>    
  //          <RegisterForm />
  //          <LoginForm onSubmit={login} />
  //        </>
  //      }*/
  //    </main>
  //    </div>
  //  );
}

export default App;