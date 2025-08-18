import { useNavigate } from "react-router-dom";

const Home: React.FC = () => {
  const navigate = useNavigate();

  return (
    <div className="home-container">
      <h1>Meu Painel de Produtos</h1>
      <div className="button-group">
        <button onClick={() => navigate("/add")}>Adicionar Produto</button>
        <button onClick={() => navigate("/list")}>Ver Lista de Produtos</button>
      </div>
    </div>
  );
};

export default Home;
