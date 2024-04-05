
import './App.css';
import UserProfile from './components/UserProfile';
import RegisterForm from './components/RegisterForm';
import LoginForm from './components/LoginForm';

function App() {
  // application main component
  const loggedIn = false; // dummy state

  // redirect user based on state
  return (
    <main>
      {loggedIn ?
        <UserProfile />
        :
        <>    
          <RegisterForm />
          <LoginForm />
        </>
      }
    </main>
  );
}

export default App;