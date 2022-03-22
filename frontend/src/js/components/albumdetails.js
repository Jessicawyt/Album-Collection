const contentDiv = document.getElementById("app");
import requestHandler from "../../requestHandler";
import { ALBUM_CONTROLLER } from "../constants";

export default{
    GetAlbum,
}

function GetAlbum(id){
    console.log('test',id);
    requestHandler.allRequest(ALBUM_CONTROLLER + id, Process);
    addEventListeners();
    // fetch(AlbumAPIURL + id)//need to reference ALBUM_CONTROLLER after we pushed SONG/REVIEW
    // .then(response => response.json())
    // .then(data => process(data))
    // .catch(err => console.log(err))   
}

function Edit(Album){
    console.log("works");
    contentDiv.innerHTML = `

    <h2>Album Detail </h2>
    <input type="hidden" value="${Album.id}" id="EditId" />
    <input type="hidden" value="${Album.artistId}" id="EditArtistId" />
    <input type="hidden" value="${Album.image}" id="EditImage" />

    <section>
    <label>Title</label>
      <input id="EditTitle" value="${Album.title}" />

      <label>Record Label</label>
      <input id="EditrecordLabel" value="${Album.recordLabel}"/>

    </section>
    <button id="${Album.id}" class="UpdateButton" >Update</button>
    `;
    let UpdateButton = document.getElementsByClassName("UpdateButton")[0];

    UpdateButton.addEventListener('click', function(){

       let EditAlbum = {
         Id: document.getElementById("EditId").value,
         Image: document.getElementById("EditImage").value,
         ArtistId: document.getElementById("EditArtistId").value,
         Title: document.getElementById("EditTitle").value,
         RecordLabel: document.getElementById("EditrecordLabel").value
       }

       requestHandler.allRequest(ALBUM_CONTROLLER, Process, "PUT", EditAlbum);

    })

  

}



function Process(album){
    console.log(album);
    contentDiv.innerHTML = `
        <ol>
            <li>
                ${album.title}
                <ul>
                    <li>Artist: ${album.artist.name}</li>
                    <li>Description: ${album.recordLabel}</li>
                    <li>Image: ${album.image}</li>
                    <li><button id=${album.id} class="editButton></button></li>
                </ul>
            </li>
        </ol>
    `;
}

function addEventListeners(){
    let editButtons = Array.from(document.getElementsByClassName('editButton'));
    editButtons.forEach(button => {
        button.addEventListener('click', function(){
            requestHandler.allRequest(ALBUM_CONTROLLER + this.id, data => {
                Edit(data);
                addEventListeners();
            })
        });
    });
}