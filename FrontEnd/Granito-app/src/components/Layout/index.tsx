import Head from '../Head';
import { Content } from '../Template/index';


export default function Layout({ children, setTema }:any) {

 
  
  return (
      <Content className="h-full w-full flex justify-center">
         <Head />
        <main className="h-full w-full flex justify-center">
          {children}
        </main>      
      </Content>    
  )
}
