import LogoPizza from "../assets/pizza.png";
import { Pizza } from "../models/Pizza";

type Props = Pizza;

const CardPizza = ({ title, description }: Props) => {
  return (
    <div className="card-items">
      <img className="card-image-pizza" src={LogoPizza} alt="Logo Pizza" />
      <div style={{ height: "50%", width: "100%" }}></div>
      <div className="card-content">
        <div>
          <div style={{ fontSize: "20px", fontWeight: 600, color: "#fff" }}>
            {title}
          </div>
          <div
            style={{
              fontSize: "20px",
              fontWeight: 600,
              color: "#fff",
              marginTop: ".5rem",
            }}
          >
            {description}
          </div>
        </div>
      </div>
    </div>
  );
};

export default CardPizza;
