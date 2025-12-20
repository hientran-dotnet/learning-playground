import { useState } from "react";
import LogoPizza from "../assets/pizza.png";
import CardPizza from "../../sections/CardPizza";
import { Pizza } from "../../models/Pizza";

type HomePageProps = {
  pizzas: Pizza[];
};
const HomePage = ({ pizzas }: HomePageProps) => {
  return (
    <div
      style={{
        height: "calc(100vh - 309px)",
        padding: "4rem 4rem",
        overflowY: "auto",
      }}
    >
      <div className="wrapper-card-items">
        {pizzas.map((pizza) => (
          <CardPizza
            key={pizza.id}
            id={pizza.id}
            title={pizza.title}
            description={pizza.description}
          />
        ))}
      </div>
    </div>
  );
};

export default HomePage;
