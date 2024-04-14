import { Component } from '@angular/core';
import { AutosService } from './services/autos.service';
import { ImageGalleryComponent } from './components/image-gallery/image-gallery.component';
import { RouterOutlet } from '@angular/router';
@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, ImageGalleryComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'proyectoCtres';

  constructor(private autosService: AutosService) {
    console.log(autosService.getAutos());
  }

}

