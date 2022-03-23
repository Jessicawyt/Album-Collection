import { ARTIST_CONTROLLER } from "../constants";
import AllRequest from "../../requestHandler"
import Artist from"./ArtistDetail"
import { appDiv } from "../constants";


export function GetArtists() {
    AllRequest.allRequest(ARTIST_CONTROLLER,Index);

    // fetch(ARTIST_CONTROLLER)
    // .then(reponse => reponse.json())
    // .then(data => Index(data))
    // .catch(error => console.error(error));
}

//return all artists
function Index(artists){
    //return "<div>test</div>";
    appDiv.innerHTML = `
        <button id="AddArtistBtn">Add an Artist</button>

        <ul>
            ${artists.map(artist =>{
                return `
                    <ul id="${artist.id}" class="singleArtist">
                        <li>${artist.name}</li>
                        <img src="${artist.heroImage}">
                    </ul>
                `;
            }).join('')}
        </ul>
    `;
    SetupEventListeners();
}

function SetupEventListeners(){
    let artists = document.getElementsByClassName('singleArtist');

    Array.from(artists).forEach(artist => {
        artist.addEventListener('click',function(){
            console.log("clicked");
            
            let artistId = artist.id;
            Artist.GetArtist(artistId);

            console.log(artistId);

        });
    });  

    let addArtistBtn = document.getElementById('AddArtistBtn');

    addArtistBtn.addEventListener('click',function(){
        AddArtist();
    });
    
}


function AddArtist(){
    
    appDiv.innerHTML = `
        
        <input type="text" id="artistName" placeholder="Name">
        <input type="text" id="artistGenre" placeholder="Genre">
        <input type="text" id="artistBio" placeholder="Bio">
        <input type="text" id="artistImage" placeholder="Image">

        <button id="saveArtistBtn" type="submit">Save</button>

    `;
   


    let saveArtistBtn = document.getElementById('saveArtistBtn');
    saveArtistBtn.addEventListener('click',function(){

        

        let artistName = document.getElementById('artistName').value;
        let artistGenre = document.getElementById('artistGenre').value;
        let artistBio = document.getElementById('artistBio').value;
        let artistImage = document.getElementById('artistImage').value;

        let newArtist = {
            Name: artistName,
            Genre: artistGenre,
            Bio: artistBio,
            HeroImage: artistImage
        }

        console.log(newArtist);

        AllRequest.allRequest(ARTIST_CONTROLLER,Index,"POST",newArtist);

    });
}
 