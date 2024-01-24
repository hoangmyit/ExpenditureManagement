import React from 'react';
import ReactDOM from 'react-dom/client';
import { HashRouter, Route, Routes } from 'react-router-dom';
import './index.scss';
import Loader from './layout/common/loaders';
import TempPage from './pages/temp-page/temp-page';
const App = React.lazy(() => import('./layout/App'));
const Dashboard = React.lazy(() => import('./pages/dashboard/dashboard'));

const root = ReactDOM.createRoot(document.getElementById('root') as HTMLElement);
root.render(
  <React.Fragment>
    <HashRouter>
      <React.Suspense fallback={<Loader />}>
        <Routes>
          <Route path={`${import.meta.env.BASE_URL}`} element={<App />}>
            <Route index element={<TempPage title='Temp page'/>} />
            <Route path={`${import.meta.env.BASE_URL}dashboard/dashboard1`} element={<Dashboard />} />
            <Route path={`${import.meta.env.BASE_URL}temp-page`} element={<TempPage title='Temp page' />} />
          </Route>
          <Route></Route>
        </Routes>
      </React.Suspense>
    </HashRouter>
  </React.Fragment>
);
