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

        <div>
            ${artists.map(artist =>{
                return `
                    <section id="${artist.id}" class="singleArtist">
                        <ul class="artistItem">
                            <li>${artist.name}</li>
                            <img src="${artist.heroImage}">
                        </ul>
                        <button class="deleteArtistBtn">Delete Artist</button>
                        
                    </section>
                `;
            }).join('')}
        </div>
    `;
    SetupEventListeners();
}

function SetupEventListeners(){
    let artists = document.getElementsByClassName('singleArtist');

    Array.from(artists).forEach(artist => {
        let artistItem = artist.getElementsByClassName('artistItem')[0];
        let deleteArtistBtn = artist.getElementsByClassName('deleteArtistBtn')[0];
        let artistId = artist.id;

        artistItem.addEventListener('click',function(){            
            Artist.GetArtist(artistId);
            console.log(artistId);
        });

        deleteArtistBtn.addEventListener('click',function(){
            DeleteArtist(artistId);
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
        <h2>Add Artist</h2>
        <section class="form">
            <input type="text" id="artistName" placeholder="Name">
            <input type="text" id="artistGenre" placeholder="Genre">
            <input type="text" id="artistBio" placeholder="Bio">
            <input type="text" id="artistImage" placeholder="Image Url">

            <button id="saveArtistBtn" type="submit">Save</button>
        </section>
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
 

function DeleteArtist(id){
    AllRequest.allRequest(ARTIST_CONTROLLER+id,Index,"DELETE");



}
