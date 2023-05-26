import "./form.css" 

export function FormLogin(){
    return(
    <>
    <header>
    </header>
    <main>
    
    <div className="form">
        <h1>Seja Bem-vindo!!</h1>
        <div className="inputs">
        <p>Seu email</p>
        <input placeholder="Ex: jose@gmail.com"></input>
        <p>Senha</p>
        <input type="password"></input>
        <h3>não é cadastrado?</h3>
        </div>
    
    </div>
    </main>
    </>
    )
};