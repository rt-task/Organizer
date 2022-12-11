import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'shortentext'
})
export class ShortenTextPipe implements PipeTransform {
  transform(value: string, charNumber = 100) {
    return value.length >= charNumber ?
      value.substring(0, charNumber).concat('...') :
      value;
  }
}
