import React from "react";
import {BrowserRouter, Route, Routes} from  'react-router-dom';
import Home from './component/Home/Home';
import Header from './component/Header/Header';
import Order from './component/Order/Order';
import AllOrder from './component/Order/AllOrder';



function App() {
  return (
    <BrowserRouter>
        <Header />
      <Routes>
        <Route path = '/' element = {<Home />}></Route>
        <Route path = '/allorder' element = {<AllOrder />}></Route>
        <Route path = '/product/:id' element = {<Order/>}></Route>
   
      </Routes>
    </BrowserRouter>
  );
}

export default App;
