import { useEffect, useState } from 'react';
import { useDispatch, useSelector } from 'react-redux';
import Head from '../src/components/Head';
import Input from '../src/components/Input';
import { Content } from '../src/components/Template';
import api from '../src/service/api'

export default function Home() {
    const [taxaURL, setTaxaURL] = useState(process.env.TAXA_URL);
    const [calculoURL, setCalculoURL] = useState(process.env.CALCULO_URL);
    const [params, setParams] = useState({
        valorInicial: 0,
        taxaJuros: 0,
        tempo: 0,
    });
    const [valorFinal, setValorFinal] = useState<number>(0)
    const handleChangeParams = (prop: any) => (value: any) => { 
        setParams({ ...params, [prop]: value });
    };
    const getTaxaJuros = async () => {
        const response = await api.get(`${taxaURL}Taxas`)
        setParams({ ...params, taxaJuros: response.data });
    }
    const getCalculo = () => {
        api.get(`${calculoURL}CalculaJuros`,{
        params
        })
        .then(response => {
            setValorFinal(response.data);
        })
        .catch(error => {
        console.error(error);
        });
      };
    const handleClick = () => {
        getCalculo();
      };

      useEffect(() =>{
        if(params.taxaJuros == 0)
            getTaxaJuros();
      },[params.taxaJuros]);
      useEffect(() =>{},[valorFinal]);

      
      return ( 
        <div className='flex flex-row'>  
            <div className="w-56  flex flex-col justify-center">   
                <div className='w-56 mb-2'>
                    <h1>Calculadora de juros</h1>
                </div>
                <div className="flex flex-col justify-center w-56">
                    <Input onChange={handleChangeParams('valorInicial')}  placeholder="valor"/>
                    <Input onChange={handleChangeParams('tempo')}  placeholder="meses"/>
                    <div className="w-56 mt-3 flex justify-center">
                        <button onClick={handleClick} type="button" className="h-10 text-white bg-gray-800 hover:bg-gray-900 focus:outline-none focus:ring-4 focus:ring-gray-300 font-medium rounded-lg text-sm px-5 py-2.5 ml-2 mb-2">Calcular</button>
                    </div>
                </div>       
            </div> 
            <div className='w-full text-start flex flex-col ml-24'>
                <p>Valor Inicial: {params.valorInicial}</p><br />
                <p>Taxa: {params.taxaJuros * 100}% </p><br />
                <p>Tempo: {params.tempo} meses </p><br />  
                <p><b>Valor Final: {valorFinal}</b></p>
            </div>
        </div>
    );
}
