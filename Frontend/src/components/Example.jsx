// This is an example component that fetches data from the backend and displays it on the frontend.
import React, { useEffect, useState } from 'react';

function ExampleComponent() {
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

export default ExampleComponent;