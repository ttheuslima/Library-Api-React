import SearchBar from '../Searchbar/SearchBar'
import './header.css'

function Header(){

    return(
    <div className='header'>
    {/* <h1> <Link to="/"id="title">Welcome to the library</Link></h1> */}
    <h1>Welcome to the library</h1>
    <nav>
      <ul>
      <SearchBar/>
      {/* <input type="search"placeholder="Procurando por um livro?..." id="pesquisa"></input> */}
      </ul>
    </nav>
    <div id="frase-gandhi">
    <h2>Be the change you want to be in the World</h2>
    <p>-Mahatma Gandhi</p>
    </div>  
    <img  id="logo"src="https://pixlok.com/wp-content/uploads/2021/10/User-Profile-Icon-9mces.png"/*src="https://d1csarkz8obe9u.cloudfront.net/posterpreviews/library-logo-design-template-45579f2f9eaf725821b915b523f191eb_screen.jpg?ts=1611149783"*/ alt="logo"></img>   
  </div>
    )
}
export default Header;