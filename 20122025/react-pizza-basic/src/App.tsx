import React, { useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import Header from "./layouts/Header";
import Footer from "./layouts/Footer";
import HomePage from "./pages/home/HomePage";
import { Pizza } from "./models/Pizza";
import HomeContainer from "./pages/home/HomeContainer";

function App() {
  return (
    <div className="App">
      {/* <Header /> */}
      <HomeContainer />
      {/* <CreatePizzaPage/> */}
      <Footer />
    </div>
  );
}

export default App;
