import {helloWorld} from "./main"
describe('Hello world', () => {

    it('says hello', () =>
    {  
        expect(helloWorld()) 
    .toEqual('Hello world!');  });
   
    }); 
   