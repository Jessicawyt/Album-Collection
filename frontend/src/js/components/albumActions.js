import requestHandler from "../../requestHandler";
const contentDiv = document.getElementById("app");
import { ALBUM_CONTROLLER } from "../constants";

import albumdetails from "./albumdetails";

export default{
    GetAlbums
}

function GetAlbums(){
    requestHandler.allRequest(ALBUM_CONTROLLER, Process)
    addEventListeners();
    // fetch("https://localhost:44368/api/album")//need to reference ALBUM_CONTROLLER after we pushed SONG/REVIEW
    // .then(response => response.json())
    // .then(data => process(data))
    // .catch(err => console.log(err))   
}

function DeleteAlbum(id){
    requestHandler.allRequest(ALBUM_CONTROLLER + id, Process, "DELETE");
    addEventListeners();
}

function Process(albums){
    console.log(albums);
    contentDiv.innerHTML = `
        <button id="createAlbum">Add Album</button>
        <ul>
            ${albums.map(album => {
                return `
                <li id=${album.id} class="album">${album.title} <button class="deleteAlbum">Delete</button></li>
                `
            }).join('')}
        </ul>
    `;
}

function addEventListeners(){

    let albumItems = Array.from(document.getElementsByClassName("album"));
    albumItems.forEach(albumItem => {
        console.log(albumItem);
        albumItem.addEventListener('click', albumdetails.GetAlbum(albumItem.id));
        let deleteButton = albumItem.getElementsByClassName('deleteAlbum')[0];
        deleteButton.addEventListener('click', DeleteAlbum(albumItem.id));
    });
}