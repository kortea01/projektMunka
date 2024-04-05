export default App;
import React, { useEffect, useState } from 'react';
import './App.css';

function App() {
  const [data, setData] = useState(null);

  useEffect(() => {
    fetchMenu();
    fetchDish(1);
  }, []);

  // list all menu items
  const fetchMenu = async () => {
    try {
      const response = await fetch('http://localhost:8000/api/menu');
      const jsonData = await response.json();
      setData(jsonData);
    } catch (error) {
      console.error('Error:', error);
    }
  };

  // show a single dish
  const fetchDish = async (id) => {
    try {
      const response = await fetch(`http://localhost:8000/api/menu/${id}`);
      const jsonData = await response.json();
      setData(jsonData);
    } catch (error) {
      console.error('Error:', error);
    }
  };

  return (
    <div>
      {data ? (
        <p>{JSON.stringify(data)}</p>
      ) : (
        <p>Loading...</p>
      )}
    </div>
  );
}
