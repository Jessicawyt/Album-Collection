import AllRequest from "../../requestHandler";
import { Render } from "./Render";
import { ARTIST_CONTROLLER } from "../constants";
import { appDiv } from "../constants";

export default{
    GetArtist
}

function GetArtist(artistId){
    AllRequest.allRequest(ARTIST_CONTROLLER + artistId,Process);
}


function Process(data){
    appDiv.innerHTML =`
        <section>
            <p>${data.name}</p>
            <p>${data.genre}</p>
            <p>${data.bio}</p>
            <img src="${data.image}">

            <ul>
                ${data.albums.map(album =>{
                    return`
                        <p>${album.title}</p>
                        <img src="${album.image}">
                    `
                }).join('')}
            </ul>
        
        </section>
    
    `;
}


