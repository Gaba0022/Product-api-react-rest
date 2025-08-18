import { useState } from "react";

interface Props {
  onSubmit: (data: { nome: string; preco: number; categoria: string }) => void;
}

const ProductForm: React.FC<Props> = ({ onSubmit }) => {
  const [nome, setNome] = useState("");
  const [preco, setPreco] = useState("");
  const [categoria, setCategoria] = useState("");

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();
    onSubmit({ nome, preco: parseFloat(preco), categoria });
    setNome("");
    setPreco("");
    setCategoria("");
  };

  return (
    <form onSubmit={handleSubmit} className="form-container">
      <input
        type="text"
        placeholder="Nome"
        value={nome}
        onChange={(e) => setNome(e.target.value)}
        required
      />
      <input
        type="number"
        placeholder="Valor"
        value={preco}
        onChange={(e) => setPreco(e.target.value)}
        required
      />
      <input
        type="text"
        placeholder="Categoria"
        value={categoria}
        onChange={(e) => setCategoria(e.target.value)}
        required
      />
      <button type="submit">Adicionar Produto</button>
    </form>
  );
};

export default ProductForm;
