import { useState, useEffect, useRef} from "react";
import { Card } from '../Components/Card'
import "./App.css";

function Carrousel() {
  const [data, setData] = useState([]);
 const carousel = useRef(null)
  useEffect(() => {
    fetch("http://localhost:5173/static/Livros.json")
      .then((response) => response.json())
      .then(setData);

 }, []);

  const handleLeftClick = (e) =>[
    e.preventDefault(),
    // console.log(carousel.current.offsetWidth),
    carousel.current.scrollLeft -= carousel.current.offsetWidth
  ]
  const handleRightClick = (e) =>[
    e.preventDefault(),
    // console.log(carousel.current.offsetWidth),
    carousel.current.scrollLeft += carousel.current.offsetWidth
  ]
  if (!data || !data.length) return null;

  function ShowButton(){
    const btn = document.querySelectorAll(".btn-image").forEach((el)=>{
      el.style.transition = "1s";
      el.style.opacity = "100%";
    })
  }
  function ButtonLeave(){
    const btn = document.querySelectorAll(".btn-image").forEach((el)=>{
      el.style.transition = "1s";
      el.style.opacity = "0%";
    })
  }
  
  
  return (
    <div className="container" onMouseOver={ShowButton} onMouseOut={ButtonLeave}>
      
      <div className="logo">
        {/* <img src="../public/images/LibraryLogo.jpg" /> */}
      </div>
      <div className="carousel" ref={carousel}>
      <div className="buttons">
          <button  onClick={handleLeftClick}>
            <img className="btn-image" src="https://cdn.iconscout.com/icon/free/png-256/right-arrow-1438234-1216195.png" />
          </button>
          <button  onClick={handleRightClick}>
            <img className="btn-image" src="https://cdn.iconscout.com/icon/free/png-256/right-arrow-1438234-1216195.png" />
          </button>
        </div>
        {data.map((item) => {
          const { id, title, autor,price, image } = item;
          return (
            <div className="item" key={id}>
              <div className="image"></div>
              <img src={image} alt={title} />
              <div className="info">
                <span className="name">{title}</span>
                <span className="autor">{autor}</span>
                {/* <span className="oldPrice">{oldPrice}</span> */}
                <span className="price">${price}</span>
              </div>
            </div>
          );
        })}
         
      </div>
      
     
    </div>
  );
}

export default Carrousel;
