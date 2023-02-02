import React from 'react'

import ReactDOM from 'react-dom/client'
import { Provider } from 'react-redux'
import { BrowserRouter as Router } from 'react-router-dom'

import SnackbarProvider from './HOC/SnackbarContext'
import App from './app'
import './index.css'
import { store } from './store'

import '@fontsource/manrope'

ReactDOM.createRoot(document.getElementById('root')).render(
    <React.StrictMode>
        <Router>
            <Provider store={store}>
                <SnackbarProvider>
                    <App />
                </SnackbarProvider>
            </Provider>
        </Router>
    </React.StrictMode>
)
