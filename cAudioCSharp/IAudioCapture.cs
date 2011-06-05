/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.1
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace cAudio {

using System;
using System.Runtime.InteropServices;

public class IAudioCapture : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal IAudioCapture(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(IAudioCapture obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~IAudioCapture() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          cAudioCSharpWrapperPINVOKE.delete_IAudioCapture(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public virtual bool initialize(string deviceName, uint frequency, AudioFormats format, uint internalBufferSize) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_initialize__SWIG_0(swigCPtr, deviceName, frequency, (int)format, internalBufferSize);
    return ret;
  }

  public virtual bool initialize(string deviceName, uint frequency, AudioFormats format) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_initialize__SWIG_1(swigCPtr, deviceName, frequency, (int)format);
    return ret;
  }

  public virtual bool initialize(string deviceName, uint frequency) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_initialize__SWIG_2(swigCPtr, deviceName, frequency);
    return ret;
  }

  public virtual bool initialize(string deviceName) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_initialize__SWIG_3(swigCPtr, deviceName);
    return ret;
  }

  public virtual bool initialize() {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_initialize__SWIG_4(swigCPtr);
    return ret;
  }

  public virtual bool isSupported() {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_isSupported(swigCPtr);
    return ret;
  }

  public virtual bool isReady() {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_isReady(swigCPtr);
    return ret;
  }

  public virtual void updateCaptureBuffer(bool force) {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_updateCaptureBuffer__SWIG_0(swigCPtr, force);
  }

  public virtual void updateCaptureBuffer() {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_updateCaptureBuffer__SWIG_1(swigCPtr);
  }

  public virtual void shutdown() {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_shutdown(swigCPtr);
  }

  public virtual bool isUpdateThreadRunning() {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_isUpdateThreadRunning(swigCPtr);
    return ret;
  }

  public virtual string getAvailableDeviceName(uint index) {
    string ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getAvailableDeviceName(swigCPtr, index);
    return ret;
  }

  public virtual uint getAvailableDeviceCount() {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getAvailableDeviceCount(swigCPtr);
    return ret;
  }

  public virtual string getDefaultDeviceName() {
    string ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getDefaultDeviceName(swigCPtr);
    return ret;
  }

  public virtual string getDeviceName() {
    string ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getDeviceName(swigCPtr);
    return ret;
  }

  public virtual uint getFrequency() {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getFrequency(swigCPtr);
    return ret;
  }

  public virtual AudioFormats getFormat() {
    AudioFormats ret = (AudioFormats)cAudioCSharpWrapperPINVOKE.IAudioCapture_getFormat(swigCPtr);
    return ret;
  }

  public virtual uint getInternalBufferSize() {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getInternalBufferSize(swigCPtr);
    return ret;
  }

  public virtual uint getSampleSize() {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getSampleSize(swigCPtr);
    return ret;
  }

  public virtual bool setDevice(string deviceName) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_setDevice(swigCPtr, deviceName);
    return ret;
  }

  public virtual bool setFrequency(uint frequency) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_setFrequency(swigCPtr, frequency);
    return ret;
  }

  public virtual bool setFormat(AudioFormats format) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_setFormat(swigCPtr, (int)format);
    return ret;
  }

  public virtual bool setInternalBufferSize(uint internalBufferSize) {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_setInternalBufferSize(swigCPtr, internalBufferSize);
    return ret;
  }

  public virtual bool beginCapture() {
    bool ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_beginCapture(swigCPtr);
    return ret;
  }

  public virtual void stopCapture() {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_stopCapture(swigCPtr);
  }

  public virtual uint getCapturedAudio(SWIGTYPE_p_void outputBuffer, uint outputBufferSize) {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getCapturedAudio(swigCPtr, SWIGTYPE_p_void.getCPtr(outputBuffer), outputBufferSize);
    return ret;
  }

  public virtual uint getCurrentCapturedAudioSize() {
    uint ret = cAudioCSharpWrapperPINVOKE.IAudioCapture_getCurrentCapturedAudioSize(swigCPtr);
    return ret;
  }

  public virtual void registerEventHandler(ICaptureEventHandler handler) {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_registerEventHandler(swigCPtr, ICaptureEventHandler.getCPtr(handler));
  }

  public virtual void unRegisterEventHandler(ICaptureEventHandler handler) {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_unRegisterEventHandler(swigCPtr, ICaptureEventHandler.getCPtr(handler));
  }

  public virtual void unRegisterAllEventHandlers() {
    cAudioCSharpWrapperPINVOKE.IAudioCapture_unRegisterAllEventHandlers(swigCPtr);
  }

}

}