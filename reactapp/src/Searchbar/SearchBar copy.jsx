import React from "react";
import "./SearchBar.css";

import SearchIcon from "@mui/icons-material/Search";
import CloseIcon from "@mui/icons-material/Close";
import { useState, useEffect } from "react";

function SearchBar({ placeholder }) {
  const [filteredData, setfilteredData] = useState([]);
  const [wordEntered, setWordEntered] = useState([]);
  const [data, setData] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5173/static/Livros.json")
      .then((response) => response.json())
      .then(setData);
  }, []);

  const handleFilter = (event) => {
    const searchWord = event.target.value;
    setWordEntered(searchWord);
    const newFilter = data.filter((value) => {
      return value.title.toLowerCase().includes(searchWord.toLowerCase());
    });
    if (searchWord === "") {
      setfilteredData([]);
    } else {
      setfilteredData(newFilter);
    }
  };
  const clearInput = () => {
    setfilteredData([]);
    setWordEntered("");
  };

  
  return (
    <div className="search">
      <header>
        <div className="searchInputs">
          <input
            id="pesquisa"
            type="text"
            placeholder={placeholder}
            value={wordEntered}
            onChange={handleFilter}
          ></input>
          {filteredData.length != 0 && (
          <div className="dataResult">
            {filteredData.slice(0, 15).map((value, key) => {
               
              return (
                <a onClick={completeInput} className="dataItem" href={value.link} target="_blanks">
                  <p>{value.title}</p>
                  
                </a>
              );
              function completeInput (){
                setWordEntered(value.title);

              }
            })}
          </div>
        )}
          <div className="searchIcon">
            {wordEntered.length == 0 ? (
              <SearchIcon /> /*<img src="https://i.pinimg.com/originals/d0/db/51/d0db51bfb8797366caebdf2a238849f0.png"/>*/
            ) : (
              <CloseIcon id="clearBtn" onClick={clearInput} />
              //<img src="https://www.veryicon.com/download/png/business/simple-line-business-icon-mix-10/close-22?s=256"id="clearBtn" onClick={clearInput}/>
            )}
          </div>
        </div>
        
      </header>
    </div>
  );
}
export default SearchBar;
