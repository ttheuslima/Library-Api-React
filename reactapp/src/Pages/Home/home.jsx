import  React  from 'react'
import './Style.css'
import { Card } from '../../Components/Card'
import { BrowserRouter, Link } from 'react-router-dom'

function mensagem(){
    alert("Testando")
}
export const respostasCertas = [];
export function acertou(){
    respostasCertas.push("x");
    console.log(respostasCertas);
}

export function Home(){
    return(
        <>
            <header>
            <img src="https://d1csarkz8obe9u.cloudfront.net/posterpreviews/library-logo-design-template-45579f2f9eaf725821b915b523f191eb_screen.jpg?ts=1611149783"></img>
            <h1 id="title">Welcome to the library</h1>
            <div id='pesquisar'>
            <button id="botao" onClick={mensagem}>Aperte aqui</button>
            <button onClick={acertou}>Acertou ein</button>

            <Link to="/testando">trocar de pag</Link>

            <input placeholder='escreva aqui...'></input>
            
            </div>
            </header>
            <main>
            
            <div id='livros'>
            <h1>Livros</h1>
            
            <div className="cards">
   
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/>
            <Card/> 
            </div>
            </div>
            </main>
            <footer>
                <p></p>
            </footer>
        </>    
    )
}