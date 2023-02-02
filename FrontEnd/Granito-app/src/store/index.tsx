import { configureStore } from '@reduxjs/toolkit';
import temaStore from './temaStore';

const store = configureStore({
    reducer: {
        tema: temaStore,
    },
});

export type RootState = ReturnType<typeof store.getState>
export type AppDispatch = typeof store.dispatch

export default store;
