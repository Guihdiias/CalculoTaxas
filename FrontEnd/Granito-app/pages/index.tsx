import { useDispatch, useSelector } from 'react-redux';
import Head from '../src/components/Head';
import { RootState } from '../src/store';
import { light, dark } from '../src/store/temaStore';
import { Content } from '../src/components/Template';

export default function Home() {
    const theme = useSelector((state: RootState) => state.tema);
    const dispatch = useDispatch();
    const handleClick = () => {
        if (theme.selected === 'dark') { dispatch(light()); } else { dispatch(dark()); }
    };
    return (
        <>
            <Head />
            <Content style={{
                backgroundColor: `${theme.colors.bgColor}`,
                color: `${theme.colors.text}`,
            }}
            >
                <div className="flex width-full justify-center">
                    <button
                        type="button"
                        onClick={handleClick}
                    >
                        botao

                    </button>
                </div>
            </Content>
        </>
    );
}
