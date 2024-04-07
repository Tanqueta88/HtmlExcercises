import { Component } from '@angular/core';
import { ImagesService } from '../../services/images.service';
import { Bike } from '../../models/Bike';

@Component({
  selector: 'app-image-gallery',
  standalone: true,
  templateUrl: './image-gallery.component.html',
  styleUrls: ['./image-gallery.component.scss']
})
export class ImageGalleryComponent {

  allImages: Bike[] = [];

  constructor(private imageService: ImagesService) {

    this.allImages = imageService.getImages();
    console.log("Todas las imagenes que me retorno el servicio previamente inyectado ");
    console.dir(this.allImages);

    console.log("Buscamos la imagen de id 6 ");
    console.dir(imageService.getImageById(6));
  }
}
