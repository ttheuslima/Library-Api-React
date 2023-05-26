import "./form.css" 
import { useState } from "react"


export function FormRegister(){
    
        const[valor, setValor] = useState('')
        //tentativa de fazer validação de senha, tentar dps
        let mudou = (event) => {
            setValor(event.target.value);
            console.log(valor)
            if (valor.length > 8){
                alert('hahaha')
            }
        }
        
    
    return(
    <>
    <div className="header">
        <h1>oi</h1>
        
    </div>
    <main>
    
    <div className="form">
        <h1>Seja Bem-vindo!!</h1>
        <div className="inputs">
        <p>Seu email</p>
        <input placeholder="Ex: jose@gmail.com"></input>
        <p>Senha</p>
        <input type="password" onChange={mudou}/>
        <p>Confirmar senha</p>
        <input type="password"></input>
        <button>Criar conta</button>
        </div>
        
    
    </div>
    </main>
    </>
    )
};