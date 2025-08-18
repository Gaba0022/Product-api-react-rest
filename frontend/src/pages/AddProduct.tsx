import { useNavigate } from "react-router-dom";
import ProductForm from "../components/ProductForm";
import { createProduct } from "../api/productApi";

const AddProduct: React.FC = () => {
  const navigate = useNavigate();

  const handleAddProduct = async (data: { nome: string; preco: number; categoria: string }) => {
    try {
      await createProduct(data);
      alert("Produto adicionado com sucesso!");
      navigate("/list");
    } catch (error) {
      console.error(error);
      alert("Erro ao adicionar produto.");
    }
  };

  return (
    <div className="page-container">
      <h2>Adicionar Produto</h2>
      <ProductForm onSubmit={handleAddProduct} />
    </div>
  );
};

export default AddProduct;
