export default function Input({ ...props }: any) {
    const onChange = (event: any) => {
        if (props.onChange) { props.onChange(event?.target.value); }
    };
    return (
        <div className="flex w-56">
            <input 
            onChange={onChange} 
            type="number" 
            className="bg-gray-50 border border-gray-300 text-gray-900 text-sm rounded-lg focus:ring-blue-500 focus:border-blue-500 block w-full mt-5 p-2.5" 
            placeholder={props.placeholder ?? ''} />
        </div>
    );
}
