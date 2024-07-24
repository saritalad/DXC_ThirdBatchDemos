import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'demo'
})
export class DemoPipe implements PipeTransform {

  transform(value: string, count: number): string {
    let str="";
    for(let i=0 ;i<count;i++)
    {
      str+=value;
    }
    return str;
  }


}
