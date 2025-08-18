import axios from "axios";

interface ProductDto {
  name: string;
  price: number;
  category: string;
  createdDate: string;
}

export interface Product {
  nome: string;
  preco: number;
  categoria: string;
}

const api = axios.create({
  baseURL: "https://localhost:7275/api/products",
});

export const getProducts = async (): Promise<Product[]> => {
  const response = await api.get<ProductDto[]>("/");
  return response.data.map((p) => ({
    nome: p.name,
    preco: p.price,
    categoria: p.category,
  }));
};

export const createProduct = (data: { nome: string; preco: number; categoria: string }) =>
  api.post("/", {
    Name: data.nome,
    Price: data.preco,
    Category: data.categoria,
  });

export default api;
