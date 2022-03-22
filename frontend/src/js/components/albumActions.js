import requestHandler from "../../requestHandler";
const contentDiv = document.getElementById("app");
import { AlbumAPIURL } from "./constant";

import GetAlbum from "./albumdetails";

export default{
    GetAlbums
}

function GetAlbums(){
    requestHandler.allRequest(AlbumAPIURL, Process)
    addEventListeners();
    // fetch("https://localhost:44368/api/album")//need to reference ALBUM_CONTROLLER after we pushed SONG/REVIEW
    // .then(response => response.json())
    // .then(data => process(data))
    // .catch(err => console.log(err))   
}

function DeleteAlbum(id){
    requestHandler.allRequest(AlbumAPIURL + id, Process(data), "DELETE");
    addEventListeners();
}

function Process(data){
    contentDiv.innerHTML = `
        <button id="createAlbum">Add Album</button>
        <ul>
            ${data.map(d => {
                return `
                <li id=${d.id} class="album">${d.title} <button class="deleteAlbum">Delete</button></li>
                `
            }).join('')}
        </ul>
    `;
}

function addEventListeners(){
    let albumItems = Array.from(document.getElementsByClassName("album"));
    albumItems.forEach(album => {
        album.addEventListener('click', GetAlbum(album.id));
        let deleteButton = album.getElementsByClassName('deleteAlbum')[0];
        deleteButton.addEventListener('click', DeleteAlbum(album.id));
    });
}