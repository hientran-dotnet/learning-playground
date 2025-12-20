import { useState } from "react";
import Header from "../../layouts/Header";
import HomePage from "./HomePage";
import { Pizza } from "../../models/Pizza";

const initialPizzas: Pizza[] = [
  {
    id: 1,
    title: "Pizza Thịt Bằm",
    description: "Thịt bằm, phô mai, sốt cà chua",
  },
  {
    id: 2,
    title: "Pizza Hải Sản",
    description: "Tôm, mực, phô mai, sốt cà chua",
  },
  { id: 3, title: "Pizza Chay", description: "Rau củ, phô mai, sốt cà chua" },
  { id: 4, title: "Pizza Đặc Biệt", description: "Thịt bò, phô mai, sốt BBQ" },
];

const HomeContainer = () => {
  const [pizzas, setPizzas] = useState<Pizza[]>(initialPizzas);

  const handleCreatePizza = () => {
    setPizzas((prev) => {
      const nextId = prev.length ? Math.max(...prev.map((p) => p.id)) + 1 : 1;

      const newPizza: Pizza = {
        id: nextId,
        title: `Pizza Mới #${nextId}`,
        description: "Mô tả pizza mới",
      };

      return [...prev, newPizza];
    });
  };

  return (
    <>
      <Header onCreatePizza={handleCreatePizza} />
      <HomePage pizzas={pizzas} />
    </>
  );
};

export default HomeContainer;
