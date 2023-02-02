import styled from 'styled-components';
// import themes from '../../themes/themes.json';

// const defaultTheme: string = themes.selected;

const Template = styled.div`
    display:flex;
    flex-direction:  row;
    width: 100%;
    height: 100%;
    min-height:100vh;
    textarea:focus, input:focus {
        box-shadow: 0 2px 0 0 #888888;
        outline: 0;
    }
    .label-float{
        position: relative;
        padding-top: 13px;
      }
      
      .label-float input{
        border: 0;
        border-bottom: 2px solid lightgrey;
        outline: none;
        min-width: 180px;
        font-size: 16px;
        transition: all .3s ease-out;
        -webkit-transition: all .3s ease-out;
        -moz-transition: all .3s ease-out;
        -webkit-appearance:none;
        border-radius: 0;
      }
      .label-float input::placeholder{
        color:transparent;
      }
      .link {
        cursor: pointer;
      }
      .label-float label{
        pointer-events: none;
        position: absolute;
        top: 0;
        left: 0;
        margin-top: 13px;
        transition: all .3s ease-out;
        -webkit-transition: all .3s ease-out;
        -moz-transition: all .3s ease-out;
      }      
      .label-float input:required:invalid + label:before{
      }
      .label-float input:focus + label,
      .label-float input:not(:placeholder-shown) + label{
        font-size: 13px;
        margin-top: 0;
      }
`;

const Content = styled.div`    
    height: 100%;
    min-width:100vw;
    min-height:100vh;
    padding-top: 90px;    
    padding-bottom: 80px;
    display:block;
`;

export { Template, Content };
