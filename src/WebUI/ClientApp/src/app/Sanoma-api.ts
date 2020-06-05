﻿/* tslint:disable */
/* eslint-disable */
//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.3.0.0 (NJsonSchema v10.1.11.0 (Newtonsoft.Json v12.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------
// ReSharper disable InconsistentNaming

import { mergeMap as _observableMergeMap, catchError as _observableCatch } from 'rxjs/operators';
import { Observable, throwError as _observableThrow, of as _observableOf } from 'rxjs';
import { Injectable, Inject, Optional, InjectionToken } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpResponseBase } from '@angular/common/http';

export const API_BASE_URL = new InjectionToken<string>('API_BASE_URL');

export interface IOrdersClient {
    getAll(): Observable<OrdersVm>;
    create(command: CreateOrderCommand): Observable<number>;
    getById(id: number): Observable<Order>;
    update(id: number, command: UpdateOrderCommand): Observable<FileResponse>;
}

@Injectable({
    providedIn: 'root'
})
export class OrdersClient implements IOrdersClient {
    private http: HttpClient;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(@Inject(HttpClient) http: HttpClient, @Optional() @Inject(API_BASE_URL) baseUrl?: string) {
        this.http = http;
        this.baseUrl = baseUrl ? baseUrl : "";
    }

    getAll(): Observable<OrdersVm> {
        let url_ = this.baseUrl + "/api/Orders";
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",			
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetAll(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetAll(<any>response_);
                } catch (e) {
                    return <Observable<OrdersVm>><any>_observableThrow(e);
                }
            } else
                return <Observable<OrdersVm>><any>_observableThrow(response_);
        }));
    }

    protected processGetAll(response: HttpResponseBase): Observable<OrdersVm> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = OrdersVm.fromJS(resultData200);
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<OrdersVm>(<any>null);
    }

    create(command: CreateOrderCommand): Observable<number> {
        let url_ = this.baseUrl + "/api/Orders";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(command);

        let options_ : any = {
            body: content_,
            observe: "response",
            responseType: "blob",			
            headers: new HttpHeaders({
                "Content-Type": "application/json", 
                "Accept": "application/json"
            })
        };

        return this.http.request("post", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processCreate(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processCreate(<any>response_);
                } catch (e) {
                    return <Observable<number>><any>_observableThrow(e);
                }
            } else
                return <Observable<number>><any>_observableThrow(response_);
        }));
    }

    protected processCreate(response: HttpResponseBase): Observable<number> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = resultData200 !== undefined ? resultData200 : <any>null;
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<number>(<any>null);
    }

    getById(id: number): Observable<Order> {
        let url_ = this.baseUrl + "/api/Orders/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        let options_ : any = {
            observe: "response",
            responseType: "blob",			
            headers: new HttpHeaders({
                "Accept": "application/json"
            })
        };

        return this.http.request("get", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processGetById(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processGetById(<any>response_);
                } catch (e) {
                    return <Observable<Order>><any>_observableThrow(e);
                }
            } else
                return <Observable<Order>><any>_observableThrow(response_);
        }));
    }

    protected processGetById(response: HttpResponseBase): Observable<Order> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            let result200: any = null;
            let resultData200 = _responseText === "" ? null : JSON.parse(_responseText, this.jsonParseReviver);
            result200 = Order.fromJS(resultData200);
            return _observableOf(result200);
            }));
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<Order>(<any>null);
    }

    update(id: number, command: UpdateOrderCommand): Observable<FileResponse> {
        let url_ = this.baseUrl + "/api/Orders/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(command);

        let options_ : any = {
            body: content_,
            observe: "response",
            responseType: "blob",			
            headers: new HttpHeaders({
                "Content-Type": "application/json", 
                "Accept": "application/octet-stream"
            })
        };

        return this.http.request("put", url_, options_).pipe(_observableMergeMap((response_ : any) => {
            return this.processUpdate(response_);
        })).pipe(_observableCatch((response_: any) => {
            if (response_ instanceof HttpResponseBase) {
                try {
                    return this.processUpdate(<any>response_);
                } catch (e) {
                    return <Observable<FileResponse>><any>_observableThrow(e);
                }
            } else
                return <Observable<FileResponse>><any>_observableThrow(response_);
        }));
    }

    protected processUpdate(response: HttpResponseBase): Observable<FileResponse> {
        const status = response.status;
        const responseBlob = 
            response instanceof HttpResponse ? response.body : 
            (<any>response).error instanceof Blob ? (<any>response).error : undefined;

        let _headers: any = {}; if (response.headers) { for (let key of response.headers.keys()) { _headers[key] = response.headers.get(key); }};
        if (status === 200 || status === 206) {
            const contentDisposition = response.headers ? response.headers.get("content-disposition") : undefined;
            const fileNameMatch = contentDisposition ? /filename="?([^"]*?)"?(;|$)/g.exec(contentDisposition) : undefined;
            const fileName = fileNameMatch && fileNameMatch.length > 1 ? fileNameMatch[1] : undefined;
            return _observableOf({ fileName: fileName, data: <any>responseBlob, status: status, headers: _headers });
        } else if (status !== 200 && status !== 204) {
            return blobToText(responseBlob).pipe(_observableMergeMap(_responseText => {
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
            }));
        }
        return _observableOf<FileResponse>(<any>null);
    }
}

export class OrdersVm implements IOrdersVm {
    lists?: OrderDto[] | undefined;

    constructor(data?: IOrdersVm) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            if (Array.isArray(_data["lists"])) {
                this.lists = [] as any;
                for (let item of _data["lists"])
                    this.lists!.push(OrderDto.fromJS(item));
            }
        }
    }

    static fromJS(data: any): OrdersVm {
        data = typeof data === 'object' ? data : {};
        let result = new OrdersVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        if (Array.isArray(this.lists)) {
            data["lists"] = [];
            for (let item of this.lists)
                data["lists"].push(item.toJSON());
        }
        return data; 
    }
}

export interface IOrdersVm {
    lists?: OrderDto[] | undefined;
}

export class OrderDto implements IOrderDto {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;

    constructor(data?: IOrderDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.emailAddress = _data["emailAddress"];
            this.submitDate = _data["submitDate"] ? new Date(_data["submitDate"].toString()) : <any>undefined;
            this.totalAmount = _data["totalAmount"];
            this.willCall = _data["willCall"];
        }
    }

    static fromJS(data: any): OrderDto {
        data = typeof data === 'object' ? data : {};
        let result = new OrderDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["emailAddress"] = this.emailAddress;
        data["submitDate"] = this.submitDate ? this.submitDate.toISOString() : <any>undefined;
        data["totalAmount"] = this.totalAmount;
        data["willCall"] = this.willCall;
        return data; 
    }
}

export interface IOrderDto {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;
}

export abstract class AuditableEntity implements IAuditableEntity {
    createdBy?: string | undefined;
    created?: Date;
    lastModifiedBy?: string | undefined;
    lastModified?: Date | undefined;

    constructor(data?: IAuditableEntity) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.createdBy = _data["createdBy"];
            this.created = _data["created"] ? new Date(_data["created"].toString()) : <any>undefined;
            this.lastModifiedBy = _data["lastModifiedBy"];
            this.lastModified = _data["lastModified"] ? new Date(_data["lastModified"].toString()) : <any>undefined;
        }
    }

    static fromJS(data: any): AuditableEntity {
        data = typeof data === 'object' ? data : {};
        throw new Error("The abstract class 'AuditableEntity' cannot be instantiated.");
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["createdBy"] = this.createdBy;
        data["created"] = this.created ? this.created.toISOString() : <any>undefined;
        data["lastModifiedBy"] = this.lastModifiedBy;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        return data; 
    }
}

export interface IAuditableEntity {
    createdBy?: string | undefined;
    created?: Date;
    lastModifiedBy?: string | undefined;
    lastModified?: Date | undefined;
}

export class Order extends AuditableEntity implements IOrder {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;

    constructor(data?: IOrder) {
        super(data);
    }

    init(_data?: any) {
        super.init(_data);
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.emailAddress = _data["emailAddress"];
            this.submitDate = _data["submitDate"] ? new Date(_data["submitDate"].toString()) : <any>undefined;
            this.totalAmount = _data["totalAmount"];
            this.willCall = _data["willCall"];
        }
    }

    static fromJS(data: any): Order {
        data = typeof data === 'object' ? data : {};
        let result = new Order();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["emailAddress"] = this.emailAddress;
        data["submitDate"] = this.submitDate ? this.submitDate.toISOString() : <any>undefined;
        data["totalAmount"] = this.totalAmount;
        data["willCall"] = this.willCall;
        super.toJSON(data);
        return data; 
    }
}

export interface IOrder extends IAuditableEntity {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;
}

export class CreateOrderCommand implements ICreateOrderCommand {
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;

    constructor(data?: ICreateOrderCommand) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.name = _data["name"];
            this.emailAddress = _data["emailAddress"];
            this.submitDate = _data["submitDate"] ? new Date(_data["submitDate"].toString()) : <any>undefined;
            this.totalAmount = _data["totalAmount"];
            this.willCall = _data["willCall"];
        }
    }

    static fromJS(data: any): CreateOrderCommand {
        data = typeof data === 'object' ? data : {};
        let result = new CreateOrderCommand();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["emailAddress"] = this.emailAddress;
        data["submitDate"] = this.submitDate ? this.submitDate.toISOString() : <any>undefined;
        data["totalAmount"] = this.totalAmount;
        data["willCall"] = this.willCall;
        return data; 
    }
}

export interface ICreateOrderCommand {
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;
}

export class UpdateOrderCommand implements IUpdateOrderCommand {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;

    constructor(data?: IUpdateOrderCommand) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(_data?: any) {
        if (_data) {
            this.id = _data["id"];
            this.name = _data["name"];
            this.emailAddress = _data["emailAddress"];
            this.submitDate = _data["submitDate"] ? new Date(_data["submitDate"].toString()) : <any>undefined;
            this.totalAmount = _data["totalAmount"];
            this.willCall = _data["willCall"];
        }
    }

    static fromJS(data: any): UpdateOrderCommand {
        data = typeof data === 'object' ? data : {};
        let result = new UpdateOrderCommand();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["emailAddress"] = this.emailAddress;
        data["submitDate"] = this.submitDate ? this.submitDate.toISOString() : <any>undefined;
        data["totalAmount"] = this.totalAmount;
        data["willCall"] = this.willCall;
        return data; 
    }
}

export interface IUpdateOrderCommand {
    id?: number;
    name?: string | undefined;
    emailAddress?: string | undefined;
    submitDate?: Date | undefined;
    totalAmount?: number;
    willCall?: boolean;
}

export interface FileResponse {
    data: Blob;
    status: number;
    fileName?: string;
    headers?: { [name: string]: any };
}

export class SwaggerException extends Error {
    message: string;
    status: number; 
    response: string; 
    headers: { [key: string]: any; };
    result: any; 

    constructor(message: string, status: number, response: string, headers: { [key: string]: any; }, result: any) {
        super();

        this.message = message;
        this.status = status;
        this.response = response;
        this.headers = headers;
        this.result = result;
    }

    protected isSwaggerException = true;

    static isSwaggerException(obj: any): obj is SwaggerException {
        return obj.isSwaggerException === true;
    }
}

function throwException(message: string, status: number, response: string, headers: { [key: string]: any; }, result?: any): Observable<any> {
    if (result !== null && result !== undefined)
        return _observableThrow(result);
    else
        return _observableThrow(new SwaggerException(message, status, response, headers, null));
}

function blobToText(blob: any): Observable<string> {
    return new Observable<string>((observer: any) => {
        if (!blob) {
            observer.next("");
            observer.complete();
        } else {
            let reader = new FileReader(); 
            reader.onload = event => { 
                observer.next((<any>event.target).result);
                observer.complete();
            };
            reader.readAsText(blob); 
        }
    });
}