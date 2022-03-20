import { appDiv } from "../constants";

export {appDiv} from "../constants";
//takes in static HTML, renders it appDiv
export function Render(html){
    appDiv.innerHTML = html;
}