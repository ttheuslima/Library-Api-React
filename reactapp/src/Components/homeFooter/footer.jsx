import React from "react";
import { useState, useEffect } from "react";
import axios from "axios";
import  './footer.css'
function Footer(){
    const baseURL ="http://localhost:5192/api/Livros/Todos_Livros";
    const [data,setData]=useState([]);

    const pedidoGet = async()=>{
      await axios.get(baseURL)
      .then(response=>{
        setData(response.data)
      })
      .catch(error=>{
        console.log(error);
      })
    }
    useEffect(()=>{
        pedidoGet();
    })
    return(
       
        <footer className="footer">
          <h1>oi</h1>
            {data.map(livro=>{
                return(
                    <>
                <h1 key={livro.livroId}></h1>
                <strong>nome</strong>
                <p>{livro.nome}</p>
                <strong>autor</strong>
                <p>{livro.autor.name}</p>
                <strong>editora</strong>
                <p>{livro.editora}</p>
                </>
                )
            })}
        </footer>
    )
}
export default Footer;