import React from "react";
import { respostasCertas } from "../Home/home";
import { acertou } from "../Home/home";
import { Link } from "react-router-dom";

export function Testando (){
    return(
        <div>
         <button onClick={acertou}>acertou ein</button>  
         <Link to="/"><button>Home</button></Link>  
        <h1>Olá meu querido, bão?</h1>

    
        </div>
    )
}