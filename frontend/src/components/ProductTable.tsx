import React from "react";
import type { Product } from "../api/productApi";

interface Props {
  products: Product[];
}

const ProductTable: React.FC<Props> = ({ products }) => {
  return (
    <table className="product-table">
      <thead>
        <tr>
          <th>Nome</th>
          <th>Valor</th>
          <th>Categoria</th>
        </tr>
      </thead>
      <tbody>
        {products.map((p, index) => (
          <tr key={index}>
            <td>{p.nome}</td>
            <td>R$ {p.preco.toFixed(2)}</td>
            <td>{p.categoria}</td>
          </tr>
        ))}
      </tbody>
    </table>
  );
};

export default ProductTable;
