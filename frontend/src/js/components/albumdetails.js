const contentDiv = document.getElementById("app");
import requestHandler from "../../requestHandler";
import { ALBUM_CONTROLLER } from "../constants";

export default{
    GetAlbum,
}

function GetAlbum(id){
    requestHandler.allRequest(ALBUM_CONTROLLER + id, Process);
    addEventListeners();
    // fetch(AlbumAPIURL + id)//need to reference ALBUM_CONTROLLER after we pushed SONG/REVIEW
    // .then(response => response.json())
    // .then(data => process(data))
    // .catch(err => console.log(err))   
}

// function Edit(data){
//     console.log("works");
//     AlbumAPIURL.contentDiv.innerHTML = `
//     <section>
//     <input type=

//     </section>
    
//     `;
// }

function Process(Album){
    contentDiv.innerHTML = `
        <ol>
            ${Album.map(album =>{
                return `
                    <li>
                        ${Album.title}
                        <ul>
                            <li>Artist: ${Album.Artist.Name}</li>
                            <li>Description: ${Album.RecordLabel}</li>
                            <li>Image: ${Album.Image}</li>
                            <li><button id=${Album.id} class="editButton></button></li>
                        </ul>
                    </li>
                `;
            }).join('')}
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