import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'shortName'
})
export class ShortNamePipe implements PipeTransform {

  transform(fullName: string): string {
    if (!fullName) return '';

    const parts = fullName.trim().split(' ');

    if (parts.length === 1) return parts[0]; // only one name

    const lastName = parts[parts.length - 1];

    const initials = parts
      .slice(0, -1)
      .map(name => name.charAt(0).toUpperCase())
      .join('');

    return `${initials} ${lastName}`;
  }

}
