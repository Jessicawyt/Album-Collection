import { ARTIST_CONTROLLER } from "../constants";
import { Render } from "./Render";

export function GetArtists() {
    fetch(ARTIST_CONTROLLER)
        .then(reponse => reponse.json())
        .then(data => Index(data))
        .catch(error => console.error(error));
}

//return all artists
function Index(artists){
    //return "<div>test</div>";
    Render(`
        <ul>
            ${artists.map(artist =>{
                return `
                        <li>${artist.name}</li>
                `;
            }).join('')}
        </ul>
    `);
}