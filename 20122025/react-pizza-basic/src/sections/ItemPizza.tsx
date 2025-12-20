import { promises } from "dns";
import { Pizza } from "../models/Pizza";
import { timeLog } from "console";

type Props = Pizza;

const ItemPizza = ({ title, description }: Props) => {
  return (
    <div>
      <div>{title}</div>
      <div>{description}</div>
    </div>
  );
};

export default ItemPizza;
