import React, { useEffect, useState } from "react";
import { useNavigate } from "react-router-dom";
import type { Product } from "../api/productApi";
import { getProducts } from "../api/productApi";
import ProductTable from "../components/ProductTable";

const ProductList: React.FC = () => {
  const [products, setProducts] = useState<Product[]>([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState("");
  const navigate = useNavigate();

  useEffect(() => {
    const fetchProducts = async () => {
      try {
        const data = await getProducts();
        setProducts(data);
      } catch (err) {
        console.error(err);
        setError("Erro ao carregar produtos.");
      } finally {
        setLoading(false);
      }
    };

    fetchProducts();
  }, []);

  if (loading) return <p>Carregando produtos...</p>;
  if (error) return <p>{error}</p>;

  return (
    <div className="page-container">
      <h2>Lista de Produtos</h2>
      <ProductTable products={products} />

      {/* Botão de voltar */}
      <button
        onClick={() => navigate("/")}
        style={{
          marginTop: "20px",
          padding: "10px 20px",
          backgroundColor: "#007bff",
          color: "#fff",
          border: "none",
          borderRadius: "5px",
          cursor: "pointer",
        }}
      >
        Voltar
      </button>
    </div>
  );
};

export default ProductList;
