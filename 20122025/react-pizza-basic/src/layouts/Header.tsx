import CardPizza from "../sections/CardPizza";
import HomePage from "../pages/home/HomePage";

type HeaderProps = {
  onCreatePizza: () => void;
};

// const Header = ({ onCreatePizza }: HeaderProps) => {
//   return (
//     <div className="flex-basic-between" style={{ padding: "1.5rem 4rem" }}>
//       <div style={{ fontSize: "40px", fontWeight: 600 }}>Pizza Dog</div>
//       <div className="btn-main">Create Pizza</div>
//     </div>
//   );
// };

// export default Header;

export default function Header({ onCreatePizza }: HeaderProps) {
  return (
    <div className="flex-basic-between" style={{ padding: "1.5rem 4rem" }}>
      <div style={{ fontSize: "40px", fontWeight: 600 }}>Pizza Dog</div>

      <button className="btn-main" onClick={onCreatePizza}>
        Create Pizza
      </button>
    </div>
  );
}
